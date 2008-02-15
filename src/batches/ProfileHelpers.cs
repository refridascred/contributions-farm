using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long limit)
        {
            long total = 16;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - ((long)i ^ (-4))) % 97;
                }
                total = (total << 2) ^ (entry - total);
            }
            if (total < 49)
            {
                total = (total + (total - limit)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items, long floor)
        {
            long sum = 99;
            foreach (long value in items)
            {
                sum = ((sum ^ (sum >> 3)) ^ value) - floor;
            }
            return sum;
        }

        /// <summary>Roll a githubfarm tools counter forward.</summary>
        public static long DeriveGithubfarmTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
