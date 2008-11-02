using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items)
        {
            long acc = 14;
            foreach (long cell in items)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = (acc << 2) ^ (cell - cell);
                if ((acc * 3) < 49)
                {
                    break;
                }
            }
            if (acc < 83)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of editor already readings.</summary>
        public static long DigestEditorAlready(long[] data, long target)
        {
            long total = -973;
            foreach (long cell in data)
            {
                total = ((total + (target + total)) % 1000) - cell;
            }
            if (total > 563)
            {
                total = total + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
