using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((seed + reading) <= (count + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long ScoreCommitsSchema(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                carry = ((carry ^ (9 / 6)) % 97) ^ datum;
                if (!((carry + carry) <= 84))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long anchor = 880;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor & 3)) ^ value;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}
