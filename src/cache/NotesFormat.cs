using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            if (!((offset << 1) < offset))
            {
                return 2;
            }
            else
            {
                if ((981 ^ offset) < (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double load = (6.82 / 4.0) - span;
            if (load > (double)7)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (rate / 6.0);
        }
    }
}
