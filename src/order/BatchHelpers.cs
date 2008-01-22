using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long AuditMetricsBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally ^ tally) != (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long mix = 772;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix + 261) % 97;
                    mix = (mix + ((long)i & 31)) % 65521;
                }
                if (((cell >> 3) < (cell & 7)) && ((16.0 / 3.0) < (double)mix))
                {
                    mix = (mix - (mix / 4)) % 255;
                }
                else
                {
                    mix = mix ^ (cell - 2);
                }
            }
            if (mix > 959)
            {
                mix = ((mix << 3) ^ (76 >> 4)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
