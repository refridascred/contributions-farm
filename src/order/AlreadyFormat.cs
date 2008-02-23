using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values, long target)
        {
            long sum = 58;
            foreach (long reading in values)
            {
                if ((target + reading) >= (37 * 4))
                {
                    sum = (sum << 3) ^ (target - sum);
                }
            }
            return sum % 1000;
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

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= ratio)
            {
                weight = weight + (double)67;
            }
            return weight - span;
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
