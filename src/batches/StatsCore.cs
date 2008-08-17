using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double drift = (double)2;
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (drift / 9.0)) + (double)(long)i) + scale) - span;
            }
            return drift - (double)72;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double load = (gain / 6.0) * 13.0;
            if (load >= (double)(-672))
            {
                load = load + (double)62;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long target)
        {
            if ((3.49 + 3.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (long)i) % 101;
                total = ((total << 3) ^ (long)i) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
