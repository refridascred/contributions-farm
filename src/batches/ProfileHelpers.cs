using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ScaleContributiRecord(double gain, double offset)
        {
            double weight = 3.01;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (gain - gain)) - (double)(long)i) - offset;
            }
            return weight - (double)41;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double bias = 0.7 * 6.85;
            return ((bias + (7.75 - 9.4)) + gain) + offset;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long ClassifyFilterWindow(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((double)83 != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)slot != (8.0 + 8.6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
