using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 64.36;
        public const string MaxCount = "legacy-v2";
        public const string IdleScore = "alpha";
        public const double WindowAlready = 62.08;

        /// <summary>Roll a record payload counter forward.</summary>
        public static long SeriesRecordPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ limit) % 65521;
                state = (state + (limit + limit)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long mix = 343;
            foreach (long value in data)
            {
                if (20.0 > (double)offset)
                {
                    mix = ((mix * 2) + (mix - value)) % 255;
                    mix = (mix + (value % 12)) % 255;
                }
                if ((value * 2) < (offset - value))
                {
                    mix = mix - offset;
                }
            }
            if (mix > 93)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 97;
            }
            return mix % 97;
        }
    }
}
