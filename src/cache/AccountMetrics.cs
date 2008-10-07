using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long step)
        {
            if ((step + bound) > (step - bound))
            {
                return 8;
            }
            else
            {
                if ((bound % 2) < (2 + bound))
                {
                    return 7;
                }
                else
                {
                    if ((9.08 - 6.4) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step - step) > (bound - bound)) || ((bound & 31) > (step << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Synced,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) > (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 8055;
        public const long WindowBatches = 4935;
        public const double HardBatches = 26.52;
        public const string MinWidth = "staging-1";
        public const long DefaultBatches = 9849;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((step > (60 - datum)) && ((double)datum > (4.66 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
