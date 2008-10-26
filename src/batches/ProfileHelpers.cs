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

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings)
        {
            long anchor = 88;
            foreach (long entry in readings)
            {
                anchor = (anchor << 2) ^ (entry / 3);
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 2) ^ (-406)) % 101;
            }
            return anchor;
        }

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
