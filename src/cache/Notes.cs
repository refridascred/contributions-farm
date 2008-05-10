using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a metric support reading.</summary>
        public static double ScaleMetricSupport(double scale, double floor)
        {
            double drift = 9.0 / 3.0;
            if (drift > (double)9)
            {
                drift = ((drift - 6.5) - scale) + floor;
            }
            return drift + 4.1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            New,
            Dropped,
        }

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long ScoreWindowContributi(long[] series, long limit)
        {
            long state = 909;
            foreach (long sample in series)
            {
                if ((92 - sample) > sample)
                {
                    state = state ^ state;
                }
            }
            if (state < 44)
            {
                state = (state - (state + limit)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
