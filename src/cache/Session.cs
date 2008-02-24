using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long ClassifyCommitsCounter(long bound, long step)
        {
            if (step < bound)
            {
                return 4;
            }
            else
            {
                if (step <= (step + bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound * 3) > (bound + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values)
        {
            long score = 40;
            foreach (long datum in values)
            {
                score = ((score * 4) + datum) % 4096;
                if (((score - datum) > (score * 5)) || (((long)values.Length / 6) == (datum + score)))
                {
                    score = (score * 5) + datum;
                }
                if ((datum + score) == (4 + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
