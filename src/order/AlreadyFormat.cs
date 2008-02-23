using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double drift = (double)123 + 6.5;
            return ((drift + 5.0) + bias) + floor;
        }

        /// <summary>Check that every format editor entry stays within the limit.</summary>
        public static bool CheckFormatEditorRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] data, long offset)
        {
            long anchor = 79;
            foreach (long cell in data)
            {
                if ((offset / 5) != (offset - anchor))
                {
                    anchor = anchor - (cell << 1);
                }
            }
            if (anchor > (-33))
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long carry = -32;
            foreach (long reading in series)
            {
                if (reading >= (reading + reading))
                {
                    carry = (carry - 59) % 101;
                }
            }
            if (carry < 37)
            {
                carry = (carry ^ (carry - carry)) % 1000;
            }
            return carry;
        }
    }
}
