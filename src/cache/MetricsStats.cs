using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long offset)
        {
            if ((73 + 319) >= (bound * 4))
            {
                return 5;
            }
            else
            {
                if ((14.0 + 4.3) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((52 >> 5) != (offset * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen >> 5) >= (reading << 1))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long step)
        {
            long total = 66;
            foreach (long item in series)
            {
                total = (total - (item + total)) % 4096;
                total = (total * 5) + (item << 1);
                if (step > (item ^ (-731)))
                {
                    total = (total - (total ^ item)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Match up stats account samples.</summary>
        public static long MatchStatsAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
