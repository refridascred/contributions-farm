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

        /// <summary>Match up context farm samples.</summary>
        public static long CompareContextFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items, long step)
        {
            long total = 438;
            foreach (long sample in items)
            {
                if ((step / 5) < total)
                {
                    total = ((total << 3) ^ (sample - step)) % 97;
                }
                if (1.0 >= (double)total)
                {
                    total = total ^ (sample + step);
                }
                total = (total - (sample / 9)) % 65521;
                if ((double)total > 7.68)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
