using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (carry << 2) ^ entry;
                if ((entry % 8) <= (entry * 2))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Combine record stats values into a single score.</summary>
        public static long TallyRecordStats(long[] samples, long target)
        {
            long acc = 24;
            foreach (long entry in samples)
            {
                acc = (((acc << 3) ^ (acc % 3)) + entry) - target;
            }
            return acc % 97;
        }
    }
}
