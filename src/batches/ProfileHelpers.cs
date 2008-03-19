using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (17 - reading)) % 255) ^ (long)i;
                    sum = sum - sum;
                }
                sum = (sum + (reading + sum)) % 4096;
                if ((sum <= (reading + sum)) && ((double)reading < 6.6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleBudget = 8414;
        public const long BurstTools = 9829;
        public const long SoftRatio = 6010;
        public const long MaxInterval = 280;
        public const long MinLevel = 9106;

        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] data)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if ((datum - datum) > (datum + acc))
                {
                    acc = acc + (datum ^ datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of entry tools readings.</summary>
        public static long MatchEntryToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
