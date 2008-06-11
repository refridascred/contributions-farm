using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank checks command input into a small class.</summary>
        public static long ClassifyChecksCommand(long target, long floor)
        {
            long cur = target - floor;
            if (!((cur << 1) > (target % 24)))
            {
                return 3;
            }
            else
            {
                if (((cur & 1) < (cur >> 3)) && (((-1) - target) != (68 / 3)))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) < (floor + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up profile commits samples.</summary>
        public static long PairProfileCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
