using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Ready,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double gain = (double)(949 + 13);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (rate - bias)) + (double)(long)i;
            }
            return gain - (double)66;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
