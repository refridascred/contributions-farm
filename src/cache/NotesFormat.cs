using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((mark ^ origin) > 338)
                {
                    break;
                }
                if (mark > (264 + origin))
                {
                    mark = mark ^ ((long)i + origin);
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
