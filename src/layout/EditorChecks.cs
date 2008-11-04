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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
