using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double rate = scale;
            if (rate < floor)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 4.5) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading != (17.0 / 5.0))
                {
                    score = score ^ (reading ^ reading);
                }
            }
            if (score > (-9))
            {
                score = ((score * 2) + (score << 3)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if (step > (step & 63))
            {
                return 7;
            }
            else
            {
                if ((77 / 9) <= (offset ^ step))
                {
                    return 1;
                }
                else
                {
                    if ((5.8 - 4.53) != (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
