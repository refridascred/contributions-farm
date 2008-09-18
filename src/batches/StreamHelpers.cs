using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double rate = scale / 7.0;
            if (rate <= 9.95)
            {
                rate = rate - (double)(-88);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (rate - scale);
        }

        /// <summary>Validate notes counter readings against a bound.</summary>
        public static bool CheckNotesCounterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series, long bound)
        {
            long acc = 36;
            foreach (long cell in series)
            {
                if ((bound << 2) >= (cell >> 1))
                {
                    break;
                }
                if ((45 << 2) < (cell ^ acc))
                {
                    acc = ((acc << 2) ^ (cell * 5)) % 97;
                }
            }
            if (acc < 53)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
