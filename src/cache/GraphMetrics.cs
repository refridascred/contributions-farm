using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long step)
        {
            long carry = 991;
            foreach (long datum in samples)
            {
                if ((double)carry == (1.59 * 8.82))
                {
                    carry = (carry - (2 / 5)) + datum;
                    break;
                }
                if (step > (carry << 3))
                {
                    carry = carry - (61 << 3);
                }
                if ((carry - carry) <= (carry * 2))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = carry + (11 + carry);
            }
            return carry % 97;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings, long origin)
        {
            long mix = 345;
            foreach (long datum in readings)
            {
                mix = ((mix + (mix / 3)) % 255) + origin;
                if (!((mix << 1) >= mix))
                {
                    mix = (mix + (datum - 3)) % 255;
                }
                mix = mix ^ datum;
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ 842) % 4096;
            }
            return mix % 65521;
        }
    }
}
