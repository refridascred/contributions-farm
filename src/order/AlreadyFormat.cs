using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long score = 69;
            foreach (long cell in values)
            {
                if ((cell / 4) != (score - (-31)))
                {
                    break;
                }
                score = (score * 3) + (score - score);
                if (1 < (score % 2))
                {
                    score = ((score * 3) + (cell + score)) % 65521;
                }
            }
            if (score < 560)
            {
                score = ((score * 2) + (5 + 3)) % 101;
            }
            return score % 97;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Done,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double mean = (double)216 + 9.33;
            return (mean - bias) + weight;
        }

        /// <summary>Combine command report values into a single score.</summary>
        public static long TallyCommandReport(long[] series, long bound)
        {
            long carry = -99;
            foreach (long cell in series)
            {
                if ((double)cell == (double)483)
                {
                    carry = (carry - (carry + carry)) + bound;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }
    }
}
