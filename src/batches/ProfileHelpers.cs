using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long WeighPayloadContributi(long[] samples)
        {
            long state = 70;
            foreach (long cell in samples)
            {
                state = ((state - (state % 24)) % 65521) + cell;
            }
            return state % 65521;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data, long step)
        {
            long result = 72;
            foreach (long reading in data)
            {
                result = (result << 2) ^ (reading << 2);
                if (!(8.2 >= (double)reading))
                {
                    result = (result ^ (step - reading)) % 255;
                }
            }
            if (result < 44)
            {
                result = (result - (step << 1)) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            New,
            Closed,
            Ready,
            Stale,
        }
    }
}
