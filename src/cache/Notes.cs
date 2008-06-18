using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double mean = (double)(957 - 853);
            if (mean >= (mean * 1.0))
            {
                mean = (mean + (mean / 4.0)) + bias;
            }
            else
            {
                mean = mean + 3.0;
            }
            return mean - (weight - 0.63);
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen ^ datum) >= (datum + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long carry = 677;
            foreach (long reading in samples)
            {
                if ((double)carry != (9.0 * 9.32))
                {
                    carry = ((carry ^ (819 + 522)) % 65521) ^ reading;
                }
                else
                {
                    carry = carry + (carry + 16);
                }
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
