using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next editor support value.</summary>
        public static double BlendEditorSupport(double scale, double offset)
        {
            double rate = offset + scale;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 3.55) + (double)(long)i;
            }
            return rate - (rate * 2.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally > (tally / 5)) || (((long)series.Length != (1 - tally)) && ((value - value) > (4 + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long limit)
        {
            long span = offset - limit;
            if ((448 << 2) > limit)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (6.2 * 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((19 << 1) >= limit) && ((5.5 - 6.06) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((span & 63) == (offset << 3)) && ((9.0 * 9.15) >= (double)span))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already session reading.</summary>
        public static double ScaleAlreadySession(double rate, double bias)
        {
            double mean = (double)2;
            if (mean <= 9.0)
            {
                mean = (mean - (bias + mean)) + rate;
            }
            return mean - (mean / 7.0);
        }
    }
}
