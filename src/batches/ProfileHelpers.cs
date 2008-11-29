using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long seed)
        {
            long mark = 99;
            foreach (long sample in series)
            {
                if ((sample + seed) >= ((-98) - mark))
                {
                    mark = (mark ^ ((long)series.Length / 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Ready,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if ((8.13 * 7.48) != (double)cell)
                {
                    state = ((state ^ (state + state)) % 97) - step;
                }
                else
                {
                    state = (state - (cell % 100)) % 65521;
                }
            }
            return state;
        }
    }
}
