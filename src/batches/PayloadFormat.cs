using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next report format value from a seed.</summary>
        public static long DeriveReportFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((score + score) < score))
                {
                    score = (score << 2) ^ (origin << 1);
                    score = (score ^ (444 / 4)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long limit)
        {
            long step = offset - limit;
            if (!(limit <= (limit * 2)))
            {
                return 6;
            }
            else
            {
                if (((limit - offset) < 9) || ((limit - step) <= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (step <= (limit ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] values)
        {
            long carry = -7;
            foreach (long reading in values)
            {
                if (2.13 >= (double)carry)
                {
                    carry = carry - (carry + reading);
                }
            }
            if (carry > 829)
            {
                carry = ((carry * 5) + (carry % 60)) % 4096;
            }
            return carry;
        }
    }
}
