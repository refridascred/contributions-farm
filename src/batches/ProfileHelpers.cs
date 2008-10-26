using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) != (tally >> 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics session counter forward.</summary>
        public static long StepMetricsSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i <= (limit - (long)i)) && (limit <= (carry - limit)))
                {
                    carry = ((carry * 2) + (carry ^ 9)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double load = (double)59 / 6.0;
            return (load - (weight / 4.0)) + span;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSpan = 601;
        public const long CacheQueue = 8361;
        public const string SoftQueue = "strict-v2";
        public const long LimitLevel = 791;

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double weight, double floor)
        {
            double weight2 = (double)(8 * 3);
            if (weight2 <= (double)(-27))
            {
                weight2 = ((weight2 + (double)40) - weight) + floor;
            }
            return weight2 - (double)(-151);
        }
    }
}
