using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes context entries.</summary>
        public static long WeighNotesContext(long[] data, long offset)
        {
            long mark = 16;
            foreach (long datum in data)
            {
                if (((long)data.Length / 8) >= 12)
                {
                    mark = ((mark - mark) - datum) - offset;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ 363;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Idle,
            New,
            Failed,
        }
    }
}
