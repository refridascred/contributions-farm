using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up stats token samples.</summary>
        public static long CompareStatsTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count schema counter pairs that satisfy a relation.</summary>
        public static long PairSchemaCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long mark = 63;
            foreach (long datum in values)
            {
                bool flag = !(datum < mark);
                if (flag)
                {
                    flag = (mark <= (mark + mark)) || flag;
                    continue;
                }
                mark = ((mark << 3) ^ (datum - 430)) % 4096;
            }
            if (mark < 292)
            {
                mark = (mark ^ (mark & 255)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 290;
        public const long IdleToken = 6428;
        public const string StepSpan = "primary-edge";
    }
}
