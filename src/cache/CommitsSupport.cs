using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Paused,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double gain = (double)(40 & 15);
            return ((gain - (double)4) + rate) + span;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
