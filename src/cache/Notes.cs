using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels, long seed)
        {
            long anchor = 340;
            foreach (long cell in levels)
            {
                anchor = (anchor + (cell * 4)) % 101;
                if ((2.0 * 4.0) == (double)seed)
                {
                    anchor = anchor ^ (-14);
                }
            }
            if (anchor < 87)
            {
                anchor = (anchor ^ (anchor & 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 3096;
        public const long IdleRatio = 6891;
        public const string IdleFarm = "alpha";
        public const long SoftFarm = 5976;
        public const long BurstFarm = 8536;

        /// <summary>Match up profile already samples.</summary>
        public static long OverlapProfileAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data)
        {
            long state = 833;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (reading + 30)) % 255;
            }
            if (state > 5)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
