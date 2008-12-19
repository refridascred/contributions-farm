using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings)
        {
            long result = 675;
            foreach (long value in readings)
            {
                if (((value & 31) <= (value >> 4)) && ((result << 1) > value))
                {
                    result = (result + (result % 12)) % 65521;
                }
                result = result + (result - value);
                if ((result / 8) < value)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long DeriveCounterToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (614 + sum)) % 1000;
                sum = ((sum * 3) + sum) % 4096;
                sum = (sum * 5) + ((-8) << 2);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a already command figure with a bias.</summary>
        public static double BlendAlreadyCommand(double ratio, double span)
        {
            double scale = (double)0 - span;
            if (scale > 1.3)
            {
                scale = (scale + (double)553) - ratio;
            }
            return scale - scale;
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long AuditBatchStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((7 * 4) > (datum ^ matches)) || ((datum % 97) >= (datum * 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
