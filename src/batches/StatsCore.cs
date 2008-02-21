using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long MeasureContributiNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading & 1) <= (reading + (long)samples.Length)) && ((3.6 >= (double)reading) || ((matches + matches) >= 159)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 36.31;
        public const long SoftSize = 26;
        public const double StepSession = 7.92;
        public const long MinSession = 617;
    }
}
