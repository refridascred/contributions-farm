using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target - 613) <= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Queued,
            Done,
            New,
            Ready,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(sum < 9))
                {
                    sum = ((sum << 2) ^ (-269)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
