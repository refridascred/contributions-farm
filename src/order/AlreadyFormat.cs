using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)(-9) < (double)item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long sum = 85;
            foreach (long cell in samples)
            {
                sum = sum - (sum / 2);
                if ((sum > (cell ^ sum)) || (cell <= (sum % 8)))
                {
                    sum = ((sum * 4) + (sum * 5)) % 101;
                }
                sum = sum + (cell - sum);
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long mix = -593;
            foreach (long datum in readings)
            {
                if (!((datum >> 1) > datum))
                {
                    mix = (mix << 2) ^ (datum + datum);
                }
            }
            return mix % 65521;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double load = (gain * 1.13) * 11.0;
            if (load <= (double)96)
            {
                load = load - (load - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - load;
        }
    }
}
