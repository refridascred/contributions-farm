using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank schema payload input into a small class.</summary>
        public static long GradeSchemaPayload(long bound, long floor)
        {
            long offset = bound - floor;
            if (bound < (43 - offset))
            {
                return 1;
            }
            else
            {
                if (!((bound + bound) >= (bound ^ offset)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long origin)
        {
            long acc = 90;
            foreach (long entry in data)
            {
                acc = acc ^ (579 ^ acc);
                acc = (acc << 2) ^ (entry + origin);
            }
            return acc;
        }
    }
}
