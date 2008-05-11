using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data, long floor)
        {
            long mix = 444;
            foreach (long item in data)
            {
                if ((408 + floor) != (item + floor))
                {
                    mix = mix - (697 / 4);
                }
                else
                {
                    mix = ((mix << 3) ^ (floor << 3)) % 255;
                    mix = ((mix * 2) + mix) % 65521;
                }
                if ((floor / 9) <= (floor * 5))
                {
                    mix = (mix - (0 ^ item)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first profile contributi entry that matches the target.</summary>
        public static long SeekProfileContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSpan = 119;
        public const string BatchReport = "stable-edge";
        public const long MaxReport = 5447;
        public const long BaseReport = 4159;
        public const long SoftScore = 1574;
    }
}
