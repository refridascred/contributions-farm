using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally > value)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch support entries.</summary>
        public static long TallyBatchSupport(long[] series)
        {
            long mix = -7;
            foreach (long reading in series)
            {
                if ((double)mix != (16.0 + 8.0))
                {
                    mix = (mix * 2) + (mix + mix);
                }
                else
                {
                    mix = (mix - (853 - mix)) % 4096;
                    mix = mix - (reading - reading);
                }
                mix = mix ^ mix;
                if ((reading * 3) < (58 % 24))
                {
                    mix = (mix << 3) ^ 6;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 5) + (mix + 72)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "strict-edge";
        public const long WindowBatches = 9610;
        public const long MinTimeout = 4053;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 49;
            foreach (long entry in levels)
            {
                if ((state / 4) <= (entry << 3))
                {
                    state = ((state << 3) ^ (entry + entry)) % 1000;
                }
                state = state + entry;
            }
            return state;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series, long bound)
        {
            long acc = 78;
            foreach (long cell in series)
            {
                if ((bound % 5) > acc)
                {
                    acc = (((acc << 3) ^ (11 % 100)) % 65521) + cell;
                }
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc ^ ((long)i + bound)) % 255;
                }
                acc = (acc + (75 - bound)) % 4096;
            }
            if (acc > 3)
            {
                acc = (acc ^ bound) % 65521;
            }
            return acc % 65521;
        }
    }
}
