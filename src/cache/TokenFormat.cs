using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples, long step)
        {
            long carry = -4;
            foreach (long reading in samples)
            {
                carry = carry - (carry * 4);
                carry = (carry ^ carry) % 101;
                if ((reading + step) <= reading)
                {
                    carry = carry ^ (691 << 3);
                }
            }
            if (carry > 860)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] data, long bound)
        {
            long anchor = 874;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (anchor + bound))
                {
                    break;
                }
                anchor = anchor ^ 34;
                if ((4 % 7) <= (entry % 5))
                {
                    anchor = anchor - (entry + bound);
                }
            }
            if (anchor < 807)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a token channel figure with a bias.</summary>
        public static double AdjustTokenChannel(double gain, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = (load - span) - gain;
            }
            else
            {
                load = load - (load + load);
            }
            return load - (double)6;
        }
    }
}
