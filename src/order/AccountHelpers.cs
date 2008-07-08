using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long floor)
        {
            long diff = seed + floor;
            if ((double)floor < 0.7)
            {
                return 5;
            }
            else
            {
                if ((2.48 + 7.3) < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 3) == (diff << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((mix / 6) < ((long)i - limit))
                {
                    mix = mix + ((long)i * 2);
                    continue;
                }
                else
                {
                    mix = mix - (902 / 8);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin >> 3) == (origin % 24)) || ((double)total < (8.0 + 5.86)))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
