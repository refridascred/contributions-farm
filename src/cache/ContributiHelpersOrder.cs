using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long StepAlreadyNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long step2)
        {
            if (!((3.0 + 7.0) >= (double)step2))
            {
                return 1;
            }
            else
            {
                if ((step << 3) != (step2 & 63))
                {
                    return 4;
                }
                else
                {
                    if (91 <= (step2 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
