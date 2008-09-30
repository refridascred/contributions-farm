using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double weight = bias;
            if (weight > (double)4)
            {
                weight = (weight + (double)47) - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(-499)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ ((long)i / 8)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long target)
        {
            if ((11.0 / 4.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((double)target != (3.86 * 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((3.16 - 4.0) > (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
