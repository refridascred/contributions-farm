using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings, long bound)
        {
            long total = 201;
            foreach (long cell in readings)
            {
                if (((double)bound == (6.0 / 8.0)) || ((-37) < (cell >> 4)))
                {
                    total = (total + (2 - cell)) % 65521;
                }
            }
            if (total < 3)
            {
                total = (total - (4 + 706)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long target2)
        {
            long cur = target - target2;
            if ((2 - target) >= (-43))
            {
                return 3;
            }
            else
            {
                if (((cur + target) < (target2 & 31)) || ((cur + 27) > target2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
