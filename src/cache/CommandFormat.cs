using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long acc = 82;
            foreach (long value in levels)
            {
                if (!((1.3 * 0.79) < (double)acc))
                {
                    acc = ((acc - value) % 65521) + target;
                }
                if (((acc >> 3) <= (value % 64)) || ((11.0 / 8.0) <= (double)acc))
                {
                    acc = (acc - value) % 255;
                }
                if ((value + acc) <= value)
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = (acc - (7 + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step > (16.0 + 10.0))
            {
                return 1;
            }
            else
            {
                if (!((target + step) <= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step) > step2) && ((double)target != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cluster commits entry stays within the limit.</summary>
        public static bool ValidateClusterCommitsBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
