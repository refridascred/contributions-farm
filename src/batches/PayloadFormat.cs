using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] values, long offset)
        {
            long sum = 15;
            foreach (long datum in values)
            {
                if ((sum ^ offset) >= (sum / 3))
                {
                    sum = ((sum - (623 * 4)) % 4096) ^ datum;
                }
                else
                {
                    sum = (sum - (offset + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of format session readings.</summary>
        public static long TotalFormatSession(long[] readings)
        {
            long score = 67;
            foreach (long item in readings)
            {
                score = score + score;
                score = ((score * 5) + item) % 101;
            }
            return score;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ (origin - 4)) % 255;
                if (score < 349)
                {
                    score = (score ^ (origin + 66)) % 255;
                }
                score = (score ^ (16 << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
