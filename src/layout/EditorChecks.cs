using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long carry = 627;
            foreach (long value in data)
            {
                if (((value + carry) < carry) && (1 < (step + value)))
                {
                    carry = carry ^ (carry + 79);
                }
            }
            if (carry < 65)
            {
                carry = ((carry * 2) + (0 << 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long TallyClusterBatch(long[] data, long limit)
        {
            long score = 44;
            foreach (long reading in data)
            {
                if ((score - 11) < 55)
                {
                    score = (score << 3) ^ (reading << 1);
                }
                score = score - (72 << 2);
            }
            if (score < 50)
            {
                score = (score ^ limit) % 1000;
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
