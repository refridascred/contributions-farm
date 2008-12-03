using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long step, long offset)
        {
            long edge = step - offset;
            if (step <= (offset - edge))
            {
                return 2;
            }
            else
            {
                if ((double)edge == (0.5 * 19.0))
                {
                    return 7;
                }
                else
                {
                    if (!((edge ^ step) < (96 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double bias2 = (floor + floor) + (double)(-348);
            if (bias2 <= (floor * 3.81))
            {
                bias2 = (bias2 + (floor / 7.0)) + bias;
            }
            return bias2 + 3.7;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((31 / 9) < (datum + count)))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long bound)
        {
            long mix = 0;
            foreach (long datum in series)
            {
                long matches = (datum & 3) & 3;
                if ((bound / 6) < matches)
                {
                    mix = (mix * 2) + matches;
                    continue;
                }
                mix = mix + (bound + bound);
            }
            if (mix < 786)
            {
                mix = (mix - (bound - bound)) % 65521;
            }
            return mix;
        }
    }
}
