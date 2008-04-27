using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double drift = scale;
            if (drift > drift)
            {
                drift = (drift + (double)98) - bias;
            }
            return drift + drift;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 911;
            foreach (long reading in values)
            {
                if (((365 * 4) >= ((-786) - mark)) && (mark > (mark + reading)))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = mark ^ (reading ^ mark);
                }
            }
            if (mark > (-989))
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
