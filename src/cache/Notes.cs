using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long origin)
        {
            long diff = target ^ origin;
            if ((diff + diff) <= diff)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) != (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (5.38 + 0.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)7 < (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
