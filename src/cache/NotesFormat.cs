using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)8) + (double)(long)i) + offset;
            }
            return drift + (double)3;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long FoldCacheSchema(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = carry ^ ((long)i % 24);
                }
                if ((4.2 * 9.16) > (double)carry)
                {
                    carry = (carry * 4) + (cell % 16);
                }
            }
            return carry % 97;
        }
    }
}
