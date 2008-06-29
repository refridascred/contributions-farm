using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if ((state ^ state) > (entry + state))
                {
                    state = (state ^ (state + state)) % 4096;
                }
            }
            if (state > 2)
            {
                state = ((state * 5) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (436 < (hits + reading))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
