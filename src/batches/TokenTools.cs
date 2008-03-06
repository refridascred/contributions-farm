using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long delta = origin + step;
            if ((365 % 24) > step)
            {
                return 1;
            }
            else
            {
                if ((step % 100) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= 86)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta % 3) == (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
