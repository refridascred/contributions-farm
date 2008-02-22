using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 3023;
        public const double SoftTimeout = 15.83;
        public const long MaxTools = 2418;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels)
        {
            long state = 31;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ entry) % 255;
                if ((entry ^ 39) < state)
                {
                    state = (state * 3) + state;
                    break;
                }
                if ((entry % 16) < (entry + entry))
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > (-869))
            {
                state = (state + (871 - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
