using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long WeighFormatEntry(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (!((double)sample == (double)288))
                {
                    mark = (mark + sample) % 97;
                }
                if (mark < (mark >> 1))
                {
                    mark = mark - (sample & 127);
                }
            }
            return mark;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
