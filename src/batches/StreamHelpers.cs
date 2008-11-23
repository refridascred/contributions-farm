using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long ScoreCounterAlready(long[] data)
        {
            long mark = 612;
            foreach (long reading in data)
            {
                if (!(8 < (mark ^ 145)))
                {
                    mark = (((mark * 3) + (mark - 836)) % 1000) - reading;
                }
            }
            return mark;
        }

        /// <summary>Match up cluster editor samples.</summary>
        public static long PairClusterEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long carry = 95;
            foreach (long value in data)
            {
                if ((6.46 * 6.11) == (double)carry)
                {
                    carry = (carry ^ (step << 3)) % 65521;
                }
                else
                {
                    carry = (carry * 2) + value;
                }
            }
            if (carry < 854)
            {
                carry = (carry * 4) + (step - carry);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
