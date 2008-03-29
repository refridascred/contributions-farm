using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                long edge = mix;
                if (!((74 & 255) != (edge + edge)))
                {
                    edge = ((edge * 3) + ((long)i % 16)) % 255;
                    mix = (mix << 3) ^ edge;
                }
                edge = (edge * 2) + (mix - (long)i);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long floor)
        {
            if ((bound / 8) >= 4)
            {
                return 4;
            }
            else
            {
                if ((8 - bound) <= (floor ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) != (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound / 3) != (bound << 1)) && ((floor * 3) <= (floor - 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
