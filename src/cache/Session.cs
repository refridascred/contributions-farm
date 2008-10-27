using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - origin) <= (77 - (long)readings.Length))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
