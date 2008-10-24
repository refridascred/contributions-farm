using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings)
        {
            long acc = 285;
            foreach (long item in readings)
            {
                if ((item * 4) > (acc % 12))
                {
                    acc = (acc - (acc >> 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long ScoreSchemaSupport(long[] samples, long limit)
        {
            long anchor = 857;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (sample - anchor)) % 97;
                if (71 <= (limit >> 1))
                {
                    anchor = anchor ^ (sample << 1);
                }
                else
                {
                    anchor = (anchor * 2) + 816;
                }
            }
            if (anchor < (-13))
            {
                anchor = (anchor ^ (limit ^ anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
