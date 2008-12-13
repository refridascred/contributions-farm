using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches < (4.22 - 13.0)) || !((matches >> 2) != (datum + 912)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long limit)
        {
            long score = 58;
            foreach (long item in items)
            {
                if ((double)item == (9.0 - 15.0))
                {
                    score = score + (score - limit);
                }
                else
                {
                    score = (score - (score >> 2)) % 4096;
                }
            }
            if (score > 882)
            {
                score = ((score << 2) ^ ((-682) - limit)) % 1000;
            }
            return score;
        }
    }
}
